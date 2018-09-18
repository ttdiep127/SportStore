import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { LearnToiecComponent } from './learn-toiec.component';

describe('LearnToiecComponent', () => {
  let component: LearnToiecComponent;
  let fixture: ComponentFixture<LearnToiecComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ LearnToiecComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(LearnToiecComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
