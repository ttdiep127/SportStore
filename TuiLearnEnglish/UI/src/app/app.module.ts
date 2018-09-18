import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { HeaderComponent } from './header/header.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { CarouselComponent } from './carousel/carousel.component';
import { AppRoutingModule } from './/app-routing.module';
import { TestToiecComponent } from './test-toiec/test-toiec.component';
import { LearnVocabularyComponent } from './learn-vocabulary/learn-vocabulary.component';
import { ChatRoomComponent } from './chat-room/chat-room.component';
import { MyLearningComponent } from './my-learning/my-learning.component';
import { LearnToiecComponent } from './learn-toiec/learn-toiec.component';
import {ReadingComponent} from './test-toiec/reading/reading.component';
import {ListeningComponent} from './test-toiec/listening/listening.component';
import {Part1Component} from './learn-toiec/listening/part1/part1.component';
import {Part2Component} from './learn-toiec/listening/part2/part2.component';
import {Part3Component} from './learn-toiec/listening/part3/part3.component';
import {Part4Component} from './learn-toiec/listening/part4/part4.component';
import {Part5Component} from './learn-toiec/reading/part5/part5.component';
import {Part6Component} from './learn-toiec/reading/part6/part6.component';
import {Part7Component} from './learn-toiec/reading/part7/part7.component';
import {FullComponent} from './test-toiec/full/full.component';
import {HomeComponent} from './home/home.component';
import { GuideToiecComponent } from './learn-toiec/guide-toiec/guide-toiec.component';

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    DashboardComponent,
    CarouselComponent,
    LearnToiecComponent,
    TestToiecComponent,
    LearnVocabularyComponent,
    ChatRoomComponent,
    ReadingComponent,
    ListeningComponent,
    Part1Component,
    Part2Component,
    Part3Component,
    Part4Component,
    Part5Component,
    Part6Component,
    Part7Component,
    MyLearningComponent,
    FullComponent,
    LearnToiecComponent,
    HomeComponent,
    GuideToiecComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
