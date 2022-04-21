import { Component } from '@angular/core';
import { BookService } from '../book-service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {

  constructor(private bookService: BookService) { }

  ngOnInit() {
    this.bookService.GetBooks();
  }
}
