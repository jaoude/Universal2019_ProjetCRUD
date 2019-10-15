import {NgModule} from '@angular/core';
import { Routes, RouterModule}
from '@angular/router';

import { InstitutionsComponent } from './institutions/institutions.component';
import { PersonsComponent } from './persons/persons.component';
import { UploadComponent } from './upload/upload.component';

const routes : Routes = [
  { path: 'persons', component: PersonsComponent },
  { path: 'Institutions', component: InstitutionsComponent},
  { path: 'FileDocuments', component: UploadComponent }
];

@NgModule ({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule{}
export const routingComponent = [PersonsComponent]