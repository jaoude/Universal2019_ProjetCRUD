import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from "@angular/forms";
import { HttpClientModule } from "@angular/common/http";
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ToastrModule } from 'ngx-toastr';
import { ReactiveFormsModule } from '@angular/forms';

import { AppComponent } from './app.component';


import { InstitutionsComponent } from './institutions/institutions.component';
import { InstitutionComponent} from './institutions/institution/institution.component';
import { InstitutionListComponent } from './institutions/institution-list/institution-list.component';
import { InstitutionService } from './shared/shared-institutions/institution.service';

import { PersonsComponent } from './persons/persons.component';
import { PersonComponent } from './persons/person/person.component';
import { PersonListComponent } from './persons/person-list/person-list.component';
import { PersonsService } from './shared/shared-persons/persons.service';
import { UniquePipe } from './filter';
import { UploadComponent } from './upload/upload.component';
import { NavigationComponent } from './navigation/navigation.component';
import { CustomMaterialModule } from './core/material.module';
import { RouterModule, Routes } from '@angular/router';

const appRoutes: Routes = [
  { path: '', component: InstitutionsComponent, data: { title: 'Inst' } },
  { path: 'institutions', component: InstitutionsComponent, data: { title: 'Institutions' } },
  { path: 'persons', component: PersonsComponent, data: { title: 'Persons' } },
  { path: 'file', component: UploadComponent, data: { title: 'Persons' } }
];

@NgModule({
  declarations: [
    AppComponent,
    
    InstitutionsComponent,
    InstitutionComponent,
    InstitutionListComponent,
    PersonsComponent,
    PersonComponent,
    PersonListComponent,
    UniquePipe,
    UploadComponent,
    NavigationComponent
  
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpClientModule,
    BrowserAnimationsModule,
   
    ReactiveFormsModule,
    ToastrModule.forRoot(),
    CustomMaterialModule,
    RouterModule.forRoot(
      appRoutes,
      { useHash: true } // <-- debugging purposes only
    ),
  ],
  providers: [InstitutionService,PersonsService],
  bootstrap: [AppComponent]
})
export class AppModule { }
