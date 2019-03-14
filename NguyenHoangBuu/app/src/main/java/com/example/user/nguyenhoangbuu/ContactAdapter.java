package com.example.user.nguyenhoangbuu;

import android.Manifest;
import android.content.Context;
import android.content.Intent;
import android.content.pm.PackageManager;
import android.net.Uri;
import android.support.v4.app.ActivityCompat;
import android.support.v4.content.ContextCompat;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ArrayAdapter;
import android.widget.ImageView;
import android.widget.TextView;

import com.example.user.nguyenhoangbuu.ContactModel;
import com.example.user.nguyenhoangbuu.R;

import java.util.List;

public class ContactAdapter extends ArrayAdapter<ContactModel> {
    private Context mContext;
    private int mResources;
    private List<ContactModel> mList;
    public ContactAdapter( Context context, int resource, List<ContactModel> objects) {
        super(context, resource, objects);
        this.mContext = context;
        this.mResources = resource;
        this.mList = objects;
    }

    @Override
    public View getView(int position, View convertView, ViewGroup parent) {
        ViewHolder viewHolder = null;
        if (viewHolder == null){
            convertView = LayoutInflater.from(mContext).inflate(mResources,parent,false);
            viewHolder = new ViewHolder();
            viewHolder.textViewTen = convertView.findViewById(R.id.Tendt);
            viewHolder.textViewMa = convertView.findViewById(R.id.Madt);
            viewHolder.textViewGia = convertView.findViewById(R.id.Giadt);
        }
        else{
            viewHolder = (ViewHolder)convertView.getTag();
        }
        final ContactModel model = mList.get(position);
        viewHolder.textViewTen.setText(String.valueOf(model.getTen()));
        viewHolder.textViewMa.setText(String.valueOf(model.getMA()));
        viewHolder.textViewGia.setText(String.valueOf(model.getGia()));


        return  convertView;
    }

    public class ViewHolder{
        TextView textViewTen;
        TextView textViewMa;
        TextView textViewGia;
    }

}

