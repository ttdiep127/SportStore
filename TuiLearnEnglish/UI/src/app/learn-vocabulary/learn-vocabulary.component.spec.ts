import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { LearnVocabularyComponent } from './learn-vocabulary.component';

describe('LearnVocabularyComponent', () => {
  let component: LearnVocabularyComponent;
  let fixture: ComponentFixture<LearnVocabularyComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ LearnVocabularyComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(LearnVocabularyComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
