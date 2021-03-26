using Microsoft.AspNetCore.Mvc;
using NHibernate;
using OnionApp.Domain.Core.DbEntities;
using OnionApp.Domain.Interfaces.Abstractions.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnionApp.Features.Employees.Presentation {

    [ApiController]
    [Route("[controller]")]
    public class EmployeesController : Controller {

        private readonly IEmployeeRepository employeeRepository;
        private readonly IRepository<Role> roleRepository;
        private readonly IUnitOfWork unitOfWork;

        public EmployeesController(IUnitOfWork unitOfWork,
            IEmployeeRepository employeeRepository) {
            this.unitOfWork = unitOfWork;
            this.employeeRepository = unitOfWork.getre;

        }

        // GET: Employees
        [HttpGet]
        public async Task<IList<GetAllEmployeeDto>> GetAllEmployeeAsync() {
            var employees = employeeRepository.GetAll();
            // TODO: use mapper
            var employeesDto = employees.Select(x =>
            new GetAllEmployeeDto() {
                Id = x.Id,
                Name = x.Name,
                RoleName = x.Role.Name
            }).ToList();

            return employeesDto;
        }

        // GET: Employees/5
        [HttpGet("{id:int:min(1)}")]
        public async Task<GetEmployeeByIdDto> GetEmployeeByIdAsync(int id) {
            var employee = await employeeRepository.GetByIdAsync(id);
            var roles = new List<Role>();
            GetEmployeeByIdDto employeeDto = new(employee, roles);

            return employeeDto;
        }


        [HttpPost]
        public async Task CreateEmployeeAsync(GetEmployeeByIdDto employeeDto) {
            var employee = new Employee() {
                Name = employeeDto.Name,
                Role = await roleRepository.GetByIdAsync(employeeDto.RoleId)
            };

            await employeeRepository.CreateAsync(employee);
            RedirectToAction("GetAllEmployeeAsync");
        }

        // TODO: implement other actions in EmployesController
        [HttpPut]
        public async Task UpdateEmployeeAsync(GetAllEmployeeDto employeeDto) {

        }

        [HttpDelete("{id:int:min(1)}")]
        public  async Task DeleteEmployeeAsync(int id) {

        }

    }
}
