import {NgModule} from '@angular/core';
import { Routes, RouterModule}
from '@angular/router';

import { UploadsComponent } from './uploads/uploads.component';
import { InstitutionsComponent } from './institutions/institutions.component';
import { PersonsComponent } from './persons/persons.component';

const routes : Routes = [
  { path: 'persons', component: PersonsComponent },
  { path: 'Institutions', component: InstitutionsComponent},
  { path: 'FileDocuments', component: UploadsComponent }
];

@NgModule ({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule{}
export const routingComponent = [PersonsComponent]