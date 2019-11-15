import { Injectable } from '@angular/core';
import { HttpClient } from "@angular/common/http";
import { Program } from './program.model';

const newLocal = "/program";
@Injectable({
  providedIn: 'root'
})
export class ProgramService {

  formData: Program;

  readonly rootURL = "https://localhost:44368/api";
  list: Program[];

  constructor(private http: HttpClient) {}

  postInstitution() {
    return this.http.post(this.rootURL + "/program", this.formData);
  }
  putInstitution() {
    return this.http.put(
      this.rootURL + "/program/" + this.formData.Id,
      this.formData
    );
  }
  deleteInstitution(id) {
    return this.http.delete(this.rootURL + "/program/" + id);
  }

  refreshList() {
    this.http
      .get(this.rootURL + newLocal)
      .toPromise()
      .then(res => (this.list = res as Program[]));
  }
}
