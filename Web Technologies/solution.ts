import { Component } from '@angular/core';


@Component({
  selector: 'like-dislike',
  template: `
      <div>
        <p>Like/Dislike component</p>
        <button [ngClass]="selectedLikeClass" class="like-button" (click)="handleLikes()">Like | <span class="likes-counter">{{likes}}</span></button>
        <button [ngClass]="selectedDislikeClass" class="dislike-button" (click)="handleDisikes()">
            Dislike | <span class="dislikes-counter">{{dislikes}}</span>
        </button>   
      </div>
  `,
  styles: [`
    .like-button, .dislike-button {
        font-size: 1rem;
        padding: 5px 10px;
        color:   #585858;
    }

    .liked, .disliked {
        font-weight: bold;
        color: #1565c0;
    }
  `]
})

export class LikeDislikeComponent {
    likes:number = 100;
    dislikes:number = 25;
    
    selectedLikeClass:string = "";
    selectedDislikeClass:string = "";
    
    isLiked:boolean = false;
    isDisliked:boolean = false;
    
    handleLikes(){
        this.isLiked = !this.isLiked;
        if(this.isLiked){
            ++this.likes;
            this.selectedLikeClass = "liked";
            
            if(this.isDisliked){
                this.isDisliked=false;
                --this.dislikes;
                this.selectedDislikeClass = "";
            }
        } else {
            --this.likes;
            this.selectedLikeClass = "";
            
        }
    }
    handleDisikes(){
        this.isDisliked = !this.isDisliked;
        if(this.isDisliked){
            ++this.dislikes;
            this.selectedDislikeClass = "disliked";
            
            if(this.isLiked){
                this.isLiked=false;
                --this.likes;
                this.selectedLikeClass = "";
            }
        } else {
            --this.dislikes;
            this.selectedDislikeClass = "";
            
        }
    }
}
