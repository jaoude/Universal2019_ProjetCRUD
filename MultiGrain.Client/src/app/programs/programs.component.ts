import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-programs',
  templateUrl: './programs.component.html',
  styles: []
})
export class ProgramsComponent implements OnInit {

  iscol4 : boolean = true;
  constructor() { }

  toggle4(){
    this.iscol4 = !this.iscol4;
  }
  ngOnInit() {
  }

}
