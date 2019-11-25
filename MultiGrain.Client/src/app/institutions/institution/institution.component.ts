import { Component, OnInit } from "@angular/core";
import { NgForm } from "@angular/forms";
import { ToastrService } from "ngx-toastr";
import { InstitutionService } from "../../shared/shared-institutions/institution.service";

@Component({
  selector: "app-institution",
  templateUrl: "./institution.component.html",
  styles: []
})
export class InstitutionComponent implements OnInit {
  constructor(
    private service: InstitutionService,
    private toastr: ToastrService
  ) {}

  ngOnInit() {
    this.resetForm();
  }

  resetForm(form?: NgForm) {
    if (form != null) form.form.reset();
    this.service.formData = {
      InstId: 0,
      lectureDuration: 0,
      mission: "",
      signature: "",
      title: "",
      vision: ""
    };
  }
  onSubmit(form: NgForm) {
    if (this.service.formData.InstId == 0) this.insertRecord(form);
    else this.updateRecord(form);
  }

  insertRecord(form: NgForm) {
    this.service.postInstitution().subscribe(
      res => {
        debugger;
        this.resetForm(form);
        this.toastr.success("Submitted successfully", "Institution Registered");
        this.service.refreshList();
      },
      err => {
        debugger;
        console.log(err);
      }
    );
  }
  updateRecord(form: NgForm) {
    this.service.putInstitution().subscribe(
      res => {
        this.resetForm(form);
        this.toastr.info("Submitted successfully", "Institution Register");
        this.service.refreshList();
      },
      err => {
        console.log(err);
      }
    );
  }
}
