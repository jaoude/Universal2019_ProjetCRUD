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
import { DocumentsComponent } from './documents/documents.component';
import { DocumentComponent } from './documents/document/document.component';
import { DocumentListComponent } from './documents/document-list/document-list.component';
import { DocumentService } from './shared/shared-documents/document.service';
import { ProgramsComponent } from './programs/programs.component';
import { ProgramComponent } from './programs/program/program.component';
import { ProgramListComponent } from './programs/program-list/program-list.component';
import { ProgramService } from './shared/shared-programs/program.service';
import { GridComponent } from './grid/grid.component';

//import { AllModules, Module } from "@ag-grid-enterprise/all-modules";
import { AgGridModule } from '@ag-grid-community/angular';
import {AllModules} from '@ag-grid-enterprise/all-modules';
const appRoutes: Routes = [
  { path: '', component: InstitutionsComponent, data: { title: 'Inst' } },
  { path: 'institutions', component: InstitutionsComponent, data: { title: 'Institutions' } },
  { path: 'Catalog', component: GridComponent, data: { title: 'Persons' } },
  { path: 'program', component: ProgramsComponent, data: { title: 'Programs' } },
  { path: 'file', component: DocumentsComponent, data: { title: 'Documents' } }
 
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
    NavigationComponent,
    DocumentsComponent,
    DocumentComponent,
    DocumentListComponent,
    ProgramsComponent,
    ProgramComponent,
    ProgramListComponent,
    GridComponent
  
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpClientModule,
    BrowserAnimationsModule,
    AgGridModule.withComponents([]),
    
    ReactiveFormsModule,
    ToastrModule.forRoot(),
    CustomMaterialModule,
    RouterModule.forRoot(
      appRoutes,
      { useHash: true } // <-- debugging purposes only
    ),
  ],
  providers: [InstitutionService,PersonsService,DocumentService,ProgramService],
  bootstrap: [AppComponent]
})
export class AppModule { }
