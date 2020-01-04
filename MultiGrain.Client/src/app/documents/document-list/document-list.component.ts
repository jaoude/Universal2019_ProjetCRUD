import { Component, OnInit } from "@angular/core";
import { DocumentService } from "src/app/shared/shared-documents/document.service";
import { ToastrService } from "ngx-toastr";
import { Document_Class } from "src/app/shared/shared-documents/document.model";
import { HttpClient } from '@angular/common/http';
import { saveAs } from 'file-saver';

@Component({
  selector: "app-document-list",
  templateUrl: "./document-list.component.html",
  styles: []
})
export class DocumentListComponent implements OnInit {
  constructor(
    private service: DocumentService,
    private toastr: ToastrService, private http: HttpClient
  ) {}

  ngOnInit() {
    this.service.refreshList();
  }
  populateForm(pd: Document_Class) {
    this.service.formData = Object.assign({}, pd);
  }

  onDelete(id) {
    if (confirm("Are you sure to delete this record ?")) {
      this.service.deleteInstitution(id).subscribe(
        res => {
          this.service.refreshList();
          this.toastr.warning("Deleted successfully", "Document Register");
        },
        err => {
          console.log(err);
        }
      );
    }
  }
  downloadFile(id,filename) {
    debugger;
    this.http.get('https://localhost:44368/api/filedocuments/'+id, { responseType: 'blob' }).subscribe(blob => {
       saveAs(blob, filename + '.pdf', {
          type: 'text/plain;charset=windows-1252' // --> or whatever you need here
       });
    });
   }
}  
