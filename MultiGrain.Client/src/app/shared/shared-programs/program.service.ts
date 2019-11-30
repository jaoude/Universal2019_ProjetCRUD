import { Injectable } from '@angular/core';
import { HttpClient } from "@angular/common/http";
import { Program } from './program.model';
import { Institution } from '../shared-institutions/institution.model';

const newLocal = "/program";
const apiinst = "/Institutions";
@Injectable({
  providedIn: 'root'
})
export class ProgramService {

  formData: Program;

  readonly rootURL = "http://localhost:59035/api";
  list: Program[];
  listInst: Institution[];
  constructor(private http: HttpClient) {}

  postProgram() {
    return this.http.post(this.rootURL + "/program", this.formData);
  }
  putProgram() {
    return this.http.put(
      this.rootURL + "/program/" + this.formData.Id,
      this.formData
    );
  }
  deleteProgram(id) {
    return this.http.delete(this.rootURL + "/program/" + id);
  }

  refreshList() {
    this.http
      .get(this.rootURL + newLocal)
      .toPromise()
      .then(res => (this.list = res as Program[]));     
  }
  getInst()
  {
    this.http
      .get(this.rootURL + apiinst)
      .toPromise()
      .then(res => (this.listInst = res as Institution[]));
  }
}
