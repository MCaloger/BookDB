import { Component, OnInit } from '@angular/core';
import { FormControl } from '@angular/forms';

@Component({
  selector: 'app-add-book-form',
  templateUrl: './add-book-form.component.html',
  styleUrls: ['./add-book-form.component.scss']
})
export class AddBookFormComponent implements OnInit {

  bookTitle = new FormControl('');

  constructor() { }

  ngOnInit(): void {
  }

}
