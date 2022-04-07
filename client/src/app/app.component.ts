import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit {
  title = 'Skinet';
  // products: IProduct[];
  // constructor(private http: HttpClient) { };
  constructor() { };
  ngOnInit(): void {
    // this.http.get('https://localhost:5001/api/products?pageSize=50').subscribe((response: IPagination) => {
    //   // console.log(response);
    //   this.products = response.data;
    // }, error => {
    //   console.log(error);
    // });
    // throw new Error('Method not implemented.');
  }
}
