import { Component, OnDestroy, OnInit } from '@angular/core';
import { UserService } from 'src/app/services/userService';
import { DateService } from 'src/app/services/dateService';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-chat',
  templateUrl: './chat.component.html',
  providers: [DateService, UserService]
})
export class ChatComponent implements OnInit, OnDestroy {
  id!: number;
  private sub: any;

  constructor(private route: ActivatedRoute) {}

  ngOnInit() {
    this.sub = this.route.params.subscribe(params => {
       this.id = +params['id'];
    });
  }

  ngOnDestroy() {
    this.sub.unsubscribe();
  }
}
