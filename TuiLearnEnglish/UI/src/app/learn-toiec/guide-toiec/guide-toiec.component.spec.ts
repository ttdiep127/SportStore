import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { GuideToiecComponent } from './guide-toiec.component';

describe('GuideToiecComponent', () => {
  let component: GuideToiecComponent;
  let fixture: ComponentFixture<GuideToiecComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ GuideToiecComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(GuideToiecComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
