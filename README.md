# Employee Management API.

<p>Developed Using <h4>C#, ASP.NET Core Framework 8.0 with a RESTful API
and Swagger api UI to applied Clean Architecture, Repository Patern, Services, Dependence Injection, Entity Framework, Auto Mapper.</h4></p>

#### Setups:
##### 1- Get new fork
##### 2- can run on any cpu X64, X86.
##### 3- Open on Visual Studio IIS , add Server Sql name and run.
##### 4- in Package Manager Console runn
```js
update-database
```


#### Layers and Folders Structure:

- [EmployeeManagement.API]
    - .[controllrs]
    - .[program.cs]
      
- [EmployeeManagement.Application]
    - .[Service]
    - .[Dto]
    - .[Prpfiles]
    - .[Persistence]
      
- .[EmployeeManagement.Domain]
    - .[Entities]
      
- .[EmployeeManagement.Persistence]
    - .[Repository]
    - .[DbContextModel]
    - .[Migrationn]

## Description.
#### Filter:
Api has filters End point "GetByHiringDateRange" to filte by Hiring Date Range, "GetByStatus'active/suspended'" to filte by Status active or suspend and "GetByDepartment" to filte by Department.

#### Sorting:
Api has sorting End point "GetAllSortingByNameDescOrASC" take type = 'Desc' Or 'ASC' and "GetAllSortingByHiringDateDescOrASC" take type = 'Desc' Or 'ASC.

#### Log:
make log in Employee table record Created date in creation and Update for each Update update date and add delete date when deleted.


## Sample of API request and response.

- [Employee Management API](#employee-management-api)
  
  - [Employee](#Employee)
    - [GetAllEmployeesLogs](#GetAllEmployeesLogs)
    - [GetAllEmployees](#GetAllEmployees)
    - [GetEmployeeById](#GetEmployeeById)
    - [GetEmployeeByName](#GetEmployeeByName)
    - [CreateEmployee](#CreateEmployee)
    - [GetByDepartment](#GetByDepartment)
    - [GetByStatus'active/suspended'](#GetByStatus'active/suspended')
    - [GetByHiringDateRange](#GetByHiringDateRange)
    - [GetAllSortingByNameDescOrASC](#GetAllSortingByNameDescOrASC)
    - [GetAllSortingByHiringDateDescOrASC](#GetAllSortingByHiringDateDescOrASC)
    - [UpdateEmployee](#UpdateEmployee)
    - [DeleteEmployee](#DeleteEmployee)


  - [Department](#Department)
    - [GetAllDepartment](#GetAllDepartment)
    - [GetDepartmentById](#GetDepartmentById)
    - [CreateDepartment](#CreateDepartment)
    - [UpdateDepartment](#UpdateDepartment)
    - [DeleteDepartment](#DeleteDepartment)
   
  
## Employee

### Get All Employees Logs

```js
POST {{host}}/api/Employee/GetAllEmployeesLogs
```

### Get All Employees Logs Response

```json
{
  {
    "id": 1,
    "name": "Alfarouk",
    "email": "user@example.com",
    "departmentId": 1,
    "hireDate": "2025-07-10T12:56:20.622",
    "status": "active",
    "createdDate": "0001-01-01T00:00:00",
    "updatedDate": "2025-07-10T15:56:50.324341",
    "deletedDate": null,
    "department": null
  },
  {
    "id": 2,
    "name": "ahmed",
    "email": "ahmed@example.com",
    "departmentId": 1,
    "hireDate": "2025-07-10T13:13:51.528",
    "status": "active",
    "createdDate": "2025-07-10T16:14:16.364715",
    "updatedDate": null,
    "deletedDate": "2025-07-10T16:18:12.0410741",
    "department": null
  }
}
```

### Create Employee

```js
POST {{host}}/api/Employee/CreateEmployee
```

### Create Employee Request

```js
{
  "name": "mohamed",
  "email": "mohamed@example.com",
  "departmentId": 2,
  "hireDate": "2025-07-10T17:35:57.489Z",
  "status": "active"
}
```

### Create Employee Response

```js
200 OK
```

```js
{
  "name": "mohamed",
  "email": "mohamed@example.com",
  "departmentId": 2,
  "hireDate": "2025-07-10T17:35:57.489Z",
  "status": "active",
  "id": 3
}
```



