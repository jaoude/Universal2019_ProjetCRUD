import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { PersonsService } from 'src/app/shared/shared-persons/persons.service';

@Component({
  selector: 'app-person',
  templateUrl: './person.component.html',
  styles: []
})
export class PersonComponent implements OnInit {

  constructor(private service: PersonsService,
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
      semestre: 0 ,
      title: '',
      credits: '',
      mode: '',
      cygle: '',
      catalognumb: ''
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
        this.toastr.success('Submitted successfully', 'Catalog Registered');
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
        this.toastr.info('Submitted successfully', 'Catalog Register');
        this.service.refreshList();
      },
      err => {
        console.log(err);
      }
    )
  }

}
