# Employee Management API

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

### Get Employee By Id

```js
POST {{host}}/api/Employee/GetEmployeeById
```

### Get Employee By Id Request

```json
{
    "id": 2
}
```

### Get Employee By Id Response

```js
200 OK
```

```js
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
```



