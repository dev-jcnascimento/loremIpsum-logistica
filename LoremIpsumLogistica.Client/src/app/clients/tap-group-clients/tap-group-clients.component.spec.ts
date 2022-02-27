import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TapGroupClientsComponent } from './tap-group-clients.component';

describe('TapGroupClientsComponent', () => {
  let component: TapGroupClientsComponent;
  let fixture: ComponentFixture<TapGroupClientsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ TapGroupClientsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(TapGroupClientsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
