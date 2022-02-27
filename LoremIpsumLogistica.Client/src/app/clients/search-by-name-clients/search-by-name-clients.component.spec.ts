import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SearchByNameClientsComponent } from './search-by-name-clients.component';

describe('SearchByNameClientsComponent', () => {
  let component: SearchByNameClientsComponent;
  let fixture: ComponentFixture<SearchByNameClientsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SearchByNameClientsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(SearchByNameClientsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
