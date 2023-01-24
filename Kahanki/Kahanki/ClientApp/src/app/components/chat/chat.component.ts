import { Component, OnDestroy, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { ChatModel } from 'src/app/models/chatModel';
import { ChatService } from 'src/app/services/chatService';

@Component({
  selector: 'app-chat',
  templateUrl: './chat.component.html',
  styleUrls: ['./chat.component.css'],
  providers: [ChatService]
})
export class ChatComponent implements OnInit, OnDestroy {
  id!: string;
  private sub: any;

  currentMessage: string = '';

  chat: ChatModel = {
    Id: '',
    messages: [],
    users: []
  }

  constructor(private route: ActivatedRoute, private chatService: ChatService) {}

  ngOnInit() {
    this.sub = this.route.params.subscribe(params => {
       this.id = params['id'];
       this.populate();
      //  this.chatService.GetChatByTargetId(this.id).toPromise().then(c => this.chat = c);
    });
  }

  ngOnDestroy() {
    this.sub.unsubscribe();
  }

  Send() {

  }

  populate() {
    this.chat = {
      Id: 'qweqwe',
      users: [
        {
          Id: '1',
          userName: 'Bob'
        },
        {
          Id: '2',
          userName: 'Alice'
        }
      ],
      messages: [
        {
          Id:'qwe',
          senderId:'1',
          content: 'qweqweqwe',
          created: new Date()
        },
        {
          Id:'qwe',
          senderId:'2',
          content: 'terwteryer',
          created: new Date()
        },
        {
          Id:'qwe',
          senderId:'1',
          content: 'qweqweqwe',
          created: new Date()
        }
      ]
    }
  }
}
