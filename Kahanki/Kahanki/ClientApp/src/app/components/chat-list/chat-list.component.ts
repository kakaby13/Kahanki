import { Component } from '@angular/core';
import { UserShortProfileModel } from 'src/app/models/UserShortProfileModel';
import { ChatService } from 'src/app/services/chatService';

@Component({
  selector: 'app-chat-list',
  templateUrl: './chat-list.component.html',
  providers: [ChatService]
})
export class ChatListComponent {

    public chatList: UserShortProfileModel[] = [];

  constructor(private chatService: ChatService) {
    chatService.GetAllChatsForCurrentUser().toPromise().then(c => this.chatList = c);
    // this.populate();
  }

  async ngOnInit()	{
  }

  public populate() {
    this.chatList = [
      {
        id: '1',
        name: 'qwe'
      },
      {
        id: '2',
        name: 'qweqw'
      },
      {
        id: '3',
        name: 'rwe'
      }
    ];
  }
}
