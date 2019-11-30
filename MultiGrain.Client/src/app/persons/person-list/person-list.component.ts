import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { Person } from 'src/app/shared/shared-persons/persons.model';
import { PersonsService } from 'src/app/shared/shared-persons/persons.service';

@Component({
  selector: 'app-person-list',
  templateUrl: './person-list.component.html',
  styles: []
})
export class PersonListComponent implements OnInit {

  constructor(private service: PersonsService,
    private toastr: ToastrService) { }

  ngOnInit() {
    
    this.service.refreshList();
  }
  populateForm(pd: Person) {
  debugger;
   this.service.formData = Object.assign({}, pd);
  }

  onDelete(InstId) {
    if (confirm('Are you sure to delete this record ?')) {
      this.service.deleteInstitution(InstId)
        .subscribe(res => {
          debugger;
          this.service.refreshList();
          this.toastr.warning('Deleted successfully', 'Catalog Register');
        },
          err => {
            debugger;
            console.log(err);
          })
    }
  }
}
