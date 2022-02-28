import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DialogEditClientsComponent } from './dialog-edit-clients.component';

describe('DialogEditClientsComponent', () => {
  let component: DialogEditClientsComponent;
  let fixture: ComponentFixture<DialogEditClientsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DialogEditClientsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DialogEditClientsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
