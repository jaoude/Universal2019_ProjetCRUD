import { Component, OnInit } from '@angular/core';
import { DocumentService } from 'src/app/shared/shared-documents/document.service';
import { NgForm } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-document',
  templateUrl: './document.component.html',
  styles: []
})
export class DocumentComponent implements OnInit {
  constructor(private service: DocumentService,
    private toastr: ToastrService) { }

  ngOnInit() {
    this.resetForm();
  }

  resetForm(form?: NgForm) {
    if (form != null)
      form.form.reset();
    this.service.formData = {
      Id: 0,
      NameAr: '',
      NameEn: '',
      NameFr: '',
      Institution: '',
      FileToUpload: null
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
        this.toastr.success('Submitted successfully', 'Document Registered');
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
        this.toastr.info('Submitted successfully', 'Document Register');
        this.service.refreshList();
      },
      err => {
        console.log(err);
      }
    )
  }

}
