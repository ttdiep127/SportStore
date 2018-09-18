import { NgModule } from '@angular/core';
import {RouterModule, Routes} from '@angular/router';
import {TestToiecComponent} from './test-toiec/test-toiec.component';
import {LearnVocabularyComponent} from './learn-vocabulary/learn-vocabulary.component';
import {MyLearningComponent} from './my-learning/my-learning.component';
import {ChatRoomComponent} from './chat-room/chat-room.component';
import {Part1Component} from './learn-toiec/listening/part1/part1.component';
import {Part2Component} from './learn-toiec/listening/part2/part2.component';
import {Part3Component} from './learn-toiec/listening/part3/part3.component';
import {Part4Component} from './learn-toiec/listening/part4/part4.component';
import {Part5Component} from './learn-toiec/reading/part5/part5.component';
import {Part6Component} from './learn-toiec/reading/part6/part6.component';
import {Part7Component} from './learn-toiec/reading/part7/part7.component';
import {ListeningComponent} from './test-toiec/listening/listening.component';
import {ReadingComponent} from './test-toiec/reading/reading.component';
import {LearnToiecComponent} from './learn-toiec/learn-toiec.component';
import {FullComponent} from './test-toiec/full/full.component';
import {HomeComponent} from './home/home.component';
import {GuideToiecComponent} from './learn-toiec/guide-toiec/guide-toiec.component';

const routes: Routes = [
  {path: '', redirectTo: '/home', pathMatch: 'full'},
  {path: 'home', component: HomeComponent},
  {path: 'learnToiec', component: LearnToiecComponent,
    children: [
      {path: 'guide', component: GuideToiecComponent},
      {
        path: 'part1', component: Part1Component
      },
      {
        path: 'part2', component: Part2Component

      },
      {
        path: 'part3', component: Part3Component
      },
      {
        path: 'part4', component: Part4Component

      },
      {
        path: 'part5', component: Part5Component
      },
      {
        path: 'part6', component: Part6Component

      },
      {
        path: 'part7', component: Part7Component

      },
    ]
  },
  {path: 'test', component: TestToiecComponent,
  children: [
    {path: 'listening', component: ListeningComponent},
    {path: 'reading', component: ReadingComponent},
    {path: 'fullTest', component: FullComponent}
  ]
  },
  {path: 'learnVocabulary', component: LearnVocabularyComponent},
  {path: 'myLearning', component: MyLearningComponent},
  {path: 'chatRoom', component: ChatRoomComponent },
];

@NgModule({
  imports: [
    [RouterModule.forRoot((routes))],
  ],
  exports: [RouterModule]
})
export class AppRoutingModule { }
