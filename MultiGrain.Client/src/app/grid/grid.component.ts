import { Component, ViewChild } from '@angular/core';

import { HttpClient } from "@angular/common/http";
import { AllModules, Module } from "@ag-grid-enterprise/all-modules";
import "@ag-grid-community/all-modules/dist/styles/ag-grid.css";
import "@ag-grid-community/all-modules/dist/styles/ag-theme-material.css";

//import {AllCommunityModules} from '@ag-grid-community/all-modules';
@Component({
  selector: 'app-grid',
  templateUrl: './grid.component.html',
   styleUrls: ['./grid.component.css']
})
export class GridComponent {

 /* columnDefs = [
    {headerName: 'Make', field: 'make' },
    {headerName: 'Model', field: 'model' },
    {headerName: 'Price', field: 'price'}
];

rowData = [
    { make: 'Toyota', model: 'Celica', price: 35000 },
    { make: 'Ford', model: 'Mondeo', price: 32000 },
    { make: 'Porsche', model: 'Boxter', price: 72000 }
];

modules = AllCommunityModules;*/
  private gridApi;
  private gridColumnApi;
 public rowData: {};
  public modules: Module[] = AllModules;

  private columnDefs;
  private defaultColDef;


  constructor(private http: HttpClient) {
    this.columnDefs = [
      {
        headerName: "Year",
        field: "year",
        //width: 20,
        rowGroup: true,
        hide: true
       
      },
      {
        headerName: "Semestre",
        field: "semestre",
        //width: 50,
        rowGroup: true,
        hide: true
        
      },
      {
        headerName: "Title",
        field: "title",
       // width: 110
      },
      {
        headerName: "Credits",
        field: "credits",
      //  width: 200
      },
      {
        headerName: "Cygle",
        field: "cygle",
       // width: 100
      },
      {
        headerName: "Instituion",
        field: "instituion",
     //   width: 100
      },
      {
        headerName: "Program",
        field: "program",
       // width: 100
      }  
    ];
    this.defaultColDef = { sortable: true , resizable: true};
  }

  onGridReady(params) {
    this.gridApi = params.api;
    this.gridColumnApi = params.columnApi;
  
    this.http
      .get(
        "http://localhost:59035/api/catalogs"
      )
      .subscribe(data => {
        this.rowData = data;
      });
  }

}
//https://raw.githubusercontent.com/ag-grid/ag-grid/master/packages/ag-grid-docs/src/olympicWinnersSmall.json