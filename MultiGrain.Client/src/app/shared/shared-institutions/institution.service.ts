import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { Institution } from "./institution.model";

const newLocal = "/Institutions";
@Injectable({
  providedIn: "root"
})
export class InstitutionService {
  formData: Institution;
  //API needed from backend for Institutions
  readonly rootURL = "http://localhost:59035/api";

  list: Institution[];

  constructor(private http: HttpClient) {}

  postInstitution() {
    return this.http.post(this.rootURL + "/institutions", this.formData);
  }
  putInstitution() {
    return this.http.put(
      this.rootURL + "/Institutions/" + this.formData.id,
      this.formData
    );
  }
  deleteInstitution(id) {
    return this.http.delete(this.rootURL + "/Institutions/" + id);
  }

  refreshList() {
    this.http
      .get(this.rootURL + newLocal)
      .toPromise()
      .then(res => (this.list = res as Institution[]));
  }
}
