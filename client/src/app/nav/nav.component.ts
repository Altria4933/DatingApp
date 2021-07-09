import {AccountService } from './../_services/account.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})
export class NavComponent implements OnInit {
  model: any = {}
  loggedIn: boolean | undefined;

  constructor(private accountService: AccountService) { }

  ngOnInit(): void {
  }

  login(){
    this.accountService.login(this.model).subscribe(Response =>{
      console.log(Response);
      this.loggedIn = true;
    },error => {
      console.log(error);
    })
  }

  logout(){
    this.loggedIn = false;
  }

}
