import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { TestToiecComponent } from './test-toiec.component';

describe('TestToiecComponent', () => {
  let component: TestToiecComponent;
  let fixture: ComponentFixture<TestToiecComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ TestToiecComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(TestToiecComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
