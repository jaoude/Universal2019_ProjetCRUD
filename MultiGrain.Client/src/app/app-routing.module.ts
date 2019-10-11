import {NgModule} from '@angular/core';
import { Routes, RouterModule}
from '@angular/router';
import {EmployeesComponent} from './employees/employees.component';
import { UploadsComponent } from './uploads/uploads.component';

const routes : Routes = [
  { path: 'students', component: EmployeesComponent },
  { path: 'Institutions', component: UploadsComponent },
  { path: 'FileDocuments', component: UploadsComponent }
];

@NgModule ({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule{}
export const routingComponent = [EmployeesComponent]