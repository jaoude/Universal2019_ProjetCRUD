import { Component, OnInit } from '@angular/core';
import { ProgramService } from 'src/app/shared/shared-programs/program.service';
import { ToastrService } from 'ngx-toastr';
import { Program } from 'src/app/shared/shared-programs/program.model';
@Component({
  selector: 'app-program-list',
  templateUrl: './program-list.component.html',
  styles: []
})
export class ProgramListComponent implements OnInit {

  constructor(private service: ProgramService,
    private toastr: ToastrService) { }

  ngOnInit() {
    
    this.service.refreshList();
  }
  populateForm(pd: Program) {
  debugger;
   this.service.formData = Object.assign({}, pd);
  }

  onDelete(InstId) {
    if (confirm('Are you sure to delete this record ?')) {
      this.service.deleteInstitution(InstId)
        .subscribe(res => {
          debugger;
          this.service.refreshList();
          this.toastr.warning('Deleted successfully', 'Program Register');
        },
          err => {
            debugger;
            console.log(err);
          })
    }
  }
}
