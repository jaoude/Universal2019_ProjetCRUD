import {NgModule} from '@angular/core';
import { Routes, RouterModule}
from '@angular/router';
import {EmployeesComponent} from './employees/employees.component';

const routes : Routes = [
  { path: 'students', component: EmployeesComponent },
  { path: 'Institutions', component: EmployeesComponent }
];

@NgModule ({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule{}
export const routingComponent = [EmployeesComponent]