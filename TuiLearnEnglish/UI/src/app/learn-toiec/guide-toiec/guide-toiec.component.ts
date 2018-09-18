import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-guide-toiec',
  templateUrl: './guide-toiec.component.html',
  styleUrls: ['./guide-toiec.component.scss']
})
export class GuideToiecComponent implements OnInit {
  selected: number;
  content1: boolean;
  content2: boolean;
  constructor() { }

  ngOnInit() {
    this.selected = 0;
    // for (const i = 1; i <= this.numberItem; i + 1) {
    //     this.content[i] = false;
    // }
    // this.content[1] = true;
    this.content1 = true;
    this.content2 = false;
  }

  OnClickListItem(ev) {
    console.log(ev);
  }

}
