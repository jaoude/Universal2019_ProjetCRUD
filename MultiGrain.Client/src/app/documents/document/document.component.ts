import { Component, OnInit, Output, EventEmitter } from '@angular/core';
import { DocumentService } from 'src/app/shared/shared-documents/document.service';
import { NgForm } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';

import { HttpEventType, HttpClient } from '@angular/common/http';
@Component({
  selector: 'app-document',
  templateUrl: './document.component.html',
  styles: []
})
export class DocumentComponent implements OnInit {

  public progress: number;
  public message: string;
  @Output() public onUploadFinished = new EventEmitter();
 
  constructor(private service: DocumentService,
    private toastr: ToastrService, private http: HttpClient) { }

  ngOnInit() {
    this.resetForm();
    this.service.getInst();
    this.service.getProg();
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
      Program: '',
      contenttype: '',
      FileToUpload: null
    }
  }
 
  public uploadFile = (files) => {
    if (files.length === 0) {
      return;
    }
 
    let fileToUpload = <File>files[0];
    const formData = new FormData();
    formData.append('fileInfoText', '{"nameAr": "'+this.service.formData.NameAr+'","nameEn": "'+this.service.formData.NameEn+ '","nameFr": "'+this.service.formData.NameFr+'", "action": null,"institutionId": null }');
    formData.append('file', fileToUpload, fileToUpload.name);
  
  
    this.http.post('http://localhost:59035/api/filedocuments', formData, {reportProgress: true, observe: 'events'})
      .subscribe(event => {
        if (event.type === HttpEventType.UploadProgress)
          this.progress = Math.round(100 * event.loaded / event.total);
        else if (event.type === HttpEventType.Response) {
          this.message = 'Upload successful!';
          this.onUploadFinished.emit(event.body);
          this.service.refreshList();
        }
      });
    
  }

}
