import { Component } from '@angular/core';

@Component({
  selector: 'my-app',
  template: `<p><button [ngClass]="className" class="up-button" (click)="handle()">{{direction}}</button></p>
  <p>{{num}}</p>
  `,
  styles: [ `
  .up-button{
    font-size:1rem;
    padding: 5px 10px;
    color: #585858;
  }
  .down-button{
    font-weight:bold;
    color:#1565c0;
  }
  ` ]
})
export class AppComponent  {
  direction:string="up"
  className:string = "";
  num:number=10;
  name = 'Angular';

  isUp:boolean = true;

  handle(){
    if(this.num<21 && this.num>=10 && this.isUp==true){
      this.num++;
      this.className="";
    }else if(this.num<=21 && this.num>10 && this.isUp==false){
      this.num--;
      this.className="down-button";
    }
    if(this.num==21 && this.isUp==true){
      this.isUp=false;
      this.direction="down";
      this.className="down-button";

    }
    else if(this.num==10 && this.isUp==false){
      this.isUp=true;
      this.direction="up";
      this.className="";

    }
  }
}
