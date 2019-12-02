import { Component, OnInit } from "@angular/core";
import { ToastrService } from "ngx-toastr";
import { Institution } from "./../../shared/shared-institutions/institution.model";
import { InstitutionService } from "./../../shared/shared-institutions/institution.service";
//import { request } from "http";
//import { routerNgProbeToken } from "@angular/router/";
import { Router } from "@angular/router";

@Component({
  selector: "app-institution-list",
  templateUrl: "./institution-list.component.html",
  styles: []
})
export class InstitutionListComponent implements OnInit {
  constructor(
    private service: InstitutionService,
    private toastr: ToastrService,
    private router: Router
  ) {
  
  }

  redirect()
  {
    this.router.navigateByUrl('program');
  }
  ngOnInit() {
    this.service.refreshList();
   
  }
  populateForm(pd: Institution) {
    debugger;

    this.service.formData = Object.assign({}, pd);
  
  }

  onDelete(InstId) {
    if (confirm("Are you sure to delete this record ?")) {
      this.service.deleteInstitution(InstId).subscribe(
        res => {
          debugger;
          this.service.refreshList();
          this.toastr.warning("Deleted successfully", "Institution Register");
        },
        err => {
          debugger;
          console.log(err);
        }
      );
    }
  }
}
