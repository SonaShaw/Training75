import { Component } from '@angular/core';


@Component({
  selector: 'my-app',
  template: `<P>{{name}}</P>
  <P>{{2+5}}</P>
  <button class="like-button" [disabled]='isDisabled'>OK</button> 
  <button class="liked">Cancel</button>
  <br/>
  <button [ngClass]="likeClass" class="like-button" (click)="handleLikes()">Like | <span class="likes-counter">{{likes}}</span></button>

  `,
  styles: [`
  .like-button{
    font-size:1rem;
    padding: 5px 10px;
    color: #585858;
  }
  .liked{
    font-weight:bold;
    color:#1565c0;
  }
  ` ]
})
export class AppComponent  {
  name = 'Angular';
  isDisabled: boolean = false;
  likes:number = 100;

  isLiked:boolean = false;
  likeClass:string = "";

  handleLikes(){
    this.isLiked = !this.isLiked;
    if(this.isLiked){
      this.likes++;
      this.likeClass = "liked";
    }else{
      this.likes--;
      this.likeClass="";
    }
  }
}
