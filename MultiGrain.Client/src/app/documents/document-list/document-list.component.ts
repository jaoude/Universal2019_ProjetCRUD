import { Component, OnInit } from "@angular/core";
import { DocumentService } from "src/app/shared/shared-documents/document.service";
import { ToastrService } from "ngx-toastr";
import { Document_Class } from "src/app/shared/shared-documents/document.model";
@Component({
  selector: "app-document-list",
  templateUrl: "./document-list.component.html",
  styles: []
})
export class DocumentListComponent implements OnInit {
  constructor(
    private service: DocumentService,
    private toastr: ToastrService
  ) {}

  ngOnInit() {
    this.service.refreshList();
  }
  populateForm(pd: Document_Class) {
    this.service.formData = Object.assign({}, pd);
  }

  onDelete(InstId) {
    if (confirm("Are you sure to delete this record ?")) {
      this.service.deleteInstitution(InstId).subscribe(
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
}
