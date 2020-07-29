import { Component, OnInit, Output, EventEmitter } from '@angular/core';

@Component({
  selector: 'app-grid-toolbar',
  templateUrl: './grid-toolbar.component.html',
  styleUrls: ['./grid-toolbar.component.scss']
})
export class GridToolbarComponent implements OnInit {
  @Output() togglingDrawer = new EventEmitter<boolean>() ;
  toggle() {
    this.togglingDrawer.emit();
  }

  constructor() { }

  ngOnInit(): void {
  }

  

}