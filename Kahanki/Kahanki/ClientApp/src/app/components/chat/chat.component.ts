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
    id: '',
    messages: [],
    users: []
  }

  constructor(private route: ActivatedRoute, private chatService: ChatService) {}

  ngOnInit() {
    this.sub = this.route.params.subscribe(params => {
       this.id = params['id'];

      this.chatService.GetChatByTargetId(this.id).toPromise().then(c => {
          this.chat = {
            id: c.id,
            users: c.users.map(s => ({
              id: s.id,
                userName: s.userName
            })),
            messages: c.messages.map(s => ({
              id: s.id,
              content: s.content,
              created: s.created,
              senderId: s.senderId}))
          };   
        });
    });
  }

  ngOnDestroy() {
    this.sub.unsubscribe();
  }

  Send() {

  }
}
