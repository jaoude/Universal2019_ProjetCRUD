import { Component, OnInit } from '@angular/core';
import { ProgramService } from 'src/app/shared/shared-programs/program.service';
import { ToastrService } from 'ngx-toastr';
import { Program } from 'src/app/shared/shared-programs/program.model';
import { Router } from '@angular/router';
@Component({
  selector: 'app-program-list',
  templateUrl: './program-list.component.html',
  styles: []
})
export class ProgramListComponent implements OnInit {

  constructor(private service: ProgramService,
    private toastr: ToastrService,
    private router : Router) { }


    redirect()
    {
 this.router.navigateByUrl('Catalog');
    }
  ngOnInit() {
    
    this.service.refreshList();
    this.service.getInst();
    
  }
  populateForm(pd: Program) {
  debugger;
   this.service.formData = Object.assign({}, pd);
  }

  onDelete(InstId) {
    if (confirm('Are you sure to delete this record ?')) {
      this.service.deleteProgram(InstId)
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
