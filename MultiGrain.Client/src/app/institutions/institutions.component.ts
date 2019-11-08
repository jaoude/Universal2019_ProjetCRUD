import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-institutions',
  templateUrl: './institutions.component.html',
  styles: []
})
export class InstitutionsComponent implements OnInit {
  iscol : boolean = true;
  constructor() { }

  toggle(){
    this.iscol = !this.iscol;
  }
  ngOnInit() {
  }

}
