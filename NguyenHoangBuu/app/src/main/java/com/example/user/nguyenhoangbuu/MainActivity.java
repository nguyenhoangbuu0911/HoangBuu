package com.example.user.nguyenhoangbuu;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.widget.ListView;

import java.util.ArrayList;
import java.util.List;

public class MainActivity extends AppCompatActivity {
    ListView listView;
    List<ContactModel> ContactModel = new ArrayList<>();

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        onInt();
        Add();
        listView.setTag(listView);
    }

    private void Add() {
        ContactModel.add(new ContactModel("Samsung galaxy","1ds5",3000000));
        ContactModel.add(new ContactModel("opple","5sdfdf",4000000));
        ContactModel.add(new ContactModel("Nokia","65dsfd",5000000));
    }

    private void onInt() {
        listView = findViewById(R.id.listview);
    }
}
