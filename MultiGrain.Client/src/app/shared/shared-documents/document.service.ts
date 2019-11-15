import { Injectable } from '@angular/core';
import { HttpClient } from "@angular/common/http";
import { Document_Class } from './document.model';
const newLocal = "/filedocuments";
@Injectable({
  providedIn: 'root'
})
export class DocumentService {

  formData: Document_Class;
  //API needed from backend for Document
  readonly rootURL = "https://localhost:44368/api";
  list: Document_Class[];

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
}
