import { Component } from '@angular/core';

@Component({
  selector: 'my-app',
  template: `<p>{{name}}</p>
  <button [ngClass]="className" class="like-button" (click)="toggle()">Click here to toggle</button>
  `,
  styles: [ `
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
  className:string = "";
  toggle(){
    if(this.className=="")
      this.className= "liked";
    else
      this.className="";
  }
}
