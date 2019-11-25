import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
// import * as $ from 'jquery';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  constructor(private http: HttpClient) { }
  ngOnInit() {
  }
}
