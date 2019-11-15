import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-documents',
  templateUrl: './documents.component.html',
  styles: []
})
export class DocumentsComponent implements OnInit {

  iscol3 : boolean = true;
  constructor() { }

  toggle3(){
    this.iscol3 = !this.iscol3;
  }
  ngOnInit() {
  }

}
