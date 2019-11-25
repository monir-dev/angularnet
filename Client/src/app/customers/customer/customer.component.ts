
import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { DataService } from '../../_services/data.service';
// import { HttpClient } from '@angular/common/http';
// import * as $ from 'jquery';

@Component({
  selector: 'customer-component',
  templateUrl: './customer.component.html',
  styleUrls: ['./customer.component.css']
})

export class CustomerComponent implements OnInit {
  showModal : boolean;



  baseUrl = "http://localhost:11819/";

  syllabuses = [];

  constructor(private http: HttpClient, private dataService: DataService) { }

  fetchData = function() {
    this.http.get(this.baseUrl + "api/syllabus").subscribe((res: Response) => this.syllabuses = res);
  }

  ngOnInit() {
    this.showModal = true;

    this.fetchData();
    // this.dataService.fetchData();
  }

}
