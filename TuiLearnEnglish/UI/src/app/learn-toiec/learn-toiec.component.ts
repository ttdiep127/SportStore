import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-learn-toiec',
  templateUrl: './learn-toiec.component.html',
  styleUrls: ['./learn-toiec.component.css']
})
export class LearnToiecComponent implements OnInit {

  selectedPart: number;
  constructor() {
  }

  ngOnInit() {
    this.selectedPart = 0;
  }

}
