import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-persons',
  templateUrl: './persons.component.html',
  styles: []
})
export class PersonsComponent implements OnInit {
  iscol2 : boolean = true;
  constructor() { }

  toggle2(){
    this.iscol2 = !this.iscol2;
  }
  ngOnInit() {
  }

}
