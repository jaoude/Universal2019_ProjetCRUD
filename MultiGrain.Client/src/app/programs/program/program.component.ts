import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { ProgramService } from 'src/app/shared/shared-programs/program.service';
@Component({
  selector: 'app-program',
  templateUrl: './program.component.html',
  styles: []
})
export class ProgramComponent implements OnInit {

  constructor(private service: ProgramService,
    private toastr: ToastrService) { }

  ngOnInit() {
    this.resetForm();
    this.service.getInst();
  }

  resetForm(form?: NgForm) {
    if (form != null)
      form.form.reset();
    this.service.formData = {
      Id: 0,
      Credits: null,
      Admission: '',
      Code: '',
      EtudesSuperieures:'',
      ObjectivesEtDebouches:'',
      Title:'',
      TitleAr:'',
      TitleEn: '',
      Institution:'',
    }
  }
  onSubmit(form: NgForm) {
    if (this.service.formData.Id == 0)
      this.insertRecord(form);
    else
      this.updateRecord(form);
  }

  insertRecord(form: NgForm) {
    this.service.postInstitution().subscribe(
      res => {
        debugger;
        this.resetForm(form);
        this.toastr.success('Submitted successfully', 'Program Registered');
        this.service.refreshList();
      },
      err => {
        debugger;
        console.log(err);
      }
    )
  }
  updateRecord(form: NgForm) {
    this.service.putInstitution().subscribe(
      res => {
        this.resetForm(form);
        this.toastr.info('Submitted successfully', 'Program Register');
        this.service.refreshList();
      },
      err => {
        console.log(err);
      }
    )
  }

}
