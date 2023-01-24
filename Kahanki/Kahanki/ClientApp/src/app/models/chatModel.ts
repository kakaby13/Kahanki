import { MessageModel } from "./MessageModel";
import { UserModel } from "./userModel";

export class ChatModel {
    public Id!: string;

    public messages!: MessageModel[];

    public users!: UserModel[];
}


