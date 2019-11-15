import { Injectable } from '@angular/core';
import { HttpClient } from "@angular/common/http";
import { Person } from './persons.model';
import { Institution } from '../shared-institutions/institution.model';
const apiinst = "/Institutions";
@Injectable({
  providedIn: 'root'
})
export class PersonsService {

  formData: Person;
  //API needed from backend for Persons
  readonly rootURL = 'http://localhost:59035/api';
  list : Person[];
  listInst: Institution[];

  constructor(private http: HttpClient) { }
  
  postInstitution() {
    return this.http.post(this.rootURL + '/Persons', this.formData);
  }
  putInstitution() {
    return this.http.put(this.rootURL + '/Persons/'+ this.formData.Id, this.formData);
  }
  deleteInstitution(id) {
    return this.http.delete(this.rootURL + '/Persons/'+ id);
  }

  refreshList(){
    this.http.get(this.rootURL + '/Persons')
    .toPromise()
    .then(res => this.list = res as Person[]);
  }
  getInst()
  {
    this.http
      .get(this.rootURL + apiinst)
      .toPromise()
      .then(res => (this.listInst = res as Institution[]));
  }
}
