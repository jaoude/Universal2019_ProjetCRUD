import { Injectable } from '@angular/core';
import { HttpClient } from "@angular/common/http";
import { Document_Class } from './document.model';
import { Institution } from '../shared-institutions/institution.model';
import { Program } from '../shared-programs/program.model';
const newLocal = "/filedocuments";
const apiinst = "/Institutions";
const apiprog = "/program"
@Injectable({
  providedIn: 'root'
})
export class DocumentService {

  formData: Document_Class;
  //API needed from backend for Document
  readonly rootURL = "http://localhost:59035/api";
  list: Document_Class[];
  listInst: Institution[];
  listProgram: Program[];
  constructor(private http: HttpClient) {}

  postInstitution() {
    return this.http.post(this.rootURL + "/filedocuments", this.formData);
  }
  putInstitution() {
    return this.http.put(
      this.rootURL + "/filedocuments/" + this.formData.Id,
      this.formData
    );
  }
  deleteInstitution(id) {
    return this.http.delete(this.rootURL + "/filedocuments/" + id);
  }

  refreshList() {
    this.http
      .get(this.rootURL + newLocal)
      .toPromise()
      .then(res => (this.list = res as Document_Class[]));
  }
  getInst()
  {
    this.http
      .get(this.rootURL + apiinst)
      .toPromise()
      .then(res => (this.listInst = res as Institution[]));
  }
  getProg()
  {
    this.http
      .get(this.rootURL + apiprog)
      .toPromise()
      .then(res => (this.listProgram = res as Program[]));
  }
}
